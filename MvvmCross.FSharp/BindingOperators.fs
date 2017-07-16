namespace MvvmCross.FSharp
 
open MvvmCross.FSharp.BindingContext

module BindingOperators =

    let (|>>) set childTarget =
        set |> bind childTarget
            
    let (>.) description targetPropertyName =
        description |> toTarget targetPropertyName

    let (>>) description quotation =
        description |> toExpression quotation

    let (>>>.) description targetPropertyName =
        description |> forProperty targetPropertyName

    let (>>>>) description quotation =
        description |> forExpression quotation
