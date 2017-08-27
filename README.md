# MvvmCross.FSharp
:nail_care: Extensions to make MvvmCross bindings more F#-ish

## Installation

Install via [NuGet](https://www.nuget.org/packages/MvvmCross.FSharp/) using:

``PM> Install-Package MvvmCross.FSharp``

## wat?

This is what bindings in F# look like:
```fsharp
let set = this.CreateBindingSet<MyView, MyViewModel>()

set
  .Bind(source)
  .To("MyList") 
  |> ignore

set
  .Bind(source)
  .For("SelectionChangedCommand")
  .To("MyCommand") 
  |> ignore
  
set.Apply()
```

MvvmCross.FSharp® allows you to use quotations instead of strings for additional type safety:

```fsharp
let set = this.CreateBindingSet<MyView, MyViewModel>()

set
|> bind source
|> toExpression <@ this.ViewModel.MyList @>
|> ignore

set
|> bind source
|> forExpression <@ source.SelectionChangedCommand @>
|> toExpression <@ this.ViewModel.MyCommand @>
|> ignore

apply set
```

`<|` ALSO PIPES `|>`


## DSL

You can also use a DSL based on the operators:

- `|>>`: The `bind` operator
- `>>`: The `to` operator
- `>>>>`: The `for` operator

Note that `>>` = to = TWO characters. The same applies to the `for` operator. Mnemonics FTW.

To use plain text instead of quotations when using the custom operators, replace the last `>` with a `.`. The number of characters in the operator remains the same, so it's still easy to remember.

Here's what the sample bindings would look like using the operator DSL:

```fsharp
let set = this.CreateBindingSet<MyView, MyViewModel>()
set |>> source >> <@ this.ViewModel.MyList @> |> ignore
set |>> source >>>> <@ source.SelectionChangedCommand @> >> <@ this.ViewModel.MyCommand @> |> ignore
apply set
```

## Framework provided bindings

A [script](https://github.com/willsb/MvvmCross.FSharp/blob/master/scrape.fsx) scrapes the MvvmCross source code and generates a source file that provides type safe `for` methods for each of the default-framework-provided bindings. This allows you to use bindings that are provided by the framework in a type safe way, like this:

```
open MvvmCross.FSharp.iOS.PropertyBinding

set
|> bind myButton
|> forTouchDown
|> toExpression <@ this.ViewModel.MyCommand @> 
|> ignore
```

## What's next?

- Make the DSL even better®
- Turn the scrape script into a Type Provider