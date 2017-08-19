#r "./packages/Hopac/lib/net45/Hopac.Core.dll"
#r "./packages/Hopac/lib/net45/Hopac.Platform.dll"
#r "./packages/Hopac/lib/net45/Hopac.dll"
#r "./packages/Http.fs/lib/net40/HttpFs.dll"

open Hopac
open Hopac.Core
open HttpFs.Client
open System.IO
open Microsoft.FSharp.Collections

let iOS = "iOS"
let iOSOpenStatements = "open UIKit" 

let droid = "Droid"
let droidOpenStatements = """
open Android.Preferences
open Android.Views
open Android.Widget
open MvvmCross.Binding.Droid.Views
"""

let openStatements = dict[droid, droidOpenStatements; iOS, iOSOpenStatements]

let processFile (file : string) =

    let project = if file.Contains("Droid") then droid else iOS
    let filePath = sprintf "MvvmCross.FSharp.%s/PropertyBinding.fs" project 
    let outFile = new StreamWriter(filePath)
    outFile.WriteLine(sprintf "namespace MvvmCross.FSharp.%s" project)
    outFile.WriteLine("")
    outFile.WriteLine(openStatements.Item(project))
    outFile.WriteLine("open MvvmCross.Binding.BindingContext")
    outFile.WriteLine("module PropertyBinding =")

    let splitString = "string"
    let template = sprintf """
    let for%s<'TView, 'TSource when 'TView :> %s and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("%s")"""

    file.Split [| '\n' |]
    |> Seq.filter (fun line -> line.Contains("const"))
    |> Seq.map (fun constant -> (constant, constant.IndexOf(splitString)))
    |> Seq.map (fun (constant, splitPosition) -> constant.Substring(splitPosition + splitString.Length, constant.Length - splitPosition - splitString.Length))
    |> Seq.map (fun text -> text.Split [| '_' |])
    |> Seq.map (fun parts -> (parts.[0], parts.[1].Substring(0, parts.[1].IndexOf(" "))))
    |> Seq.distinctBy (fun tuple -> snd tuple)
    |> Seq.map (fun tuple -> template (snd tuple) (fst tuple) (snd tuple))
    |> Seq.iter (fun letBinding -> outFile.WriteLine(letBinding))

    outFile.Close()

let urls = 
  [ "https://raw.githubusercontent.com/MvvmCross/MvvmCross/master/MvvmCross/Binding/iOS/MvxIosPropertyBinding.cs";
    "https://raw.githubusercontent.com/MvvmCross/MvvmCross/develop/MvvmCross/Binding/Droid/MvxAndroidPropertyBinding.cs" ]
|> Seq.map (Request.createUrl Get)
|> Seq.map (Request.responseAsString)
|> Seq.map run
|> Seq.iter processFile