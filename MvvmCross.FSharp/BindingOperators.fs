namespace MvvmCross.FSharp
 
open MvvmCross.FSharp.BindingContext

module BindingOperators = 

    let (|>>) set childTarget =
        set |> bind childTarget

    let (>>) targetPropertyName description =
        targetPropertyName |> toTarget description

    let (>>>>) targetPropertyName description =
        targetPropertyName |> forProperty description        