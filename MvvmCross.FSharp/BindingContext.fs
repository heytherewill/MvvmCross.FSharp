namespace MvvmCross.FSharp

open Microsoft.FSharp.Quotations.Patterns
open MvvmCross.Binding
open MvvmCross.Binding.BindingContext

module BindingContext =
    let createBindingSet<'TTarget, 'TSource 
        when 'TTarget : not struct 
        and 'TTarget :> IMvxBindingContextOwner>
        (target: 'TTarget) =
        target.CreateBindingSet<'TTarget, 'TSource>()
    
    let createBinding<'TTarget when 'TTarget : not struct>
        (contextOwner: IMvxBindingContextOwner)
        (target: 'TTarget) =
        new MvxFluentBindingDescription<'TTarget>(contextOwner, target)

    let bind
        childTarget
        (set: MvxFluentBindingDescriptionSet<'TOwningTarget, 'TSource>) =
        set.Bind(childTarget)

    let forProperty 
        (targetPropertyName: string)
        (description: MvxFluentBindingDescription<'TTarget, 'TSource>) =
        description.For(targetPropertyName)

    let forExpression<'TTarget, 'TSource, 'T
        when 'TTarget : not struct
        and 'TSource : not struct
        and 'T : not struct>
        (quotation: Quotations.Expr)
        (description: MvxFluentBindingDescription<'TTarget, 'TSource>) =
        
        match quotation with
        | PropertyGet(_, propertyInfo, _) -> description.For(propertyInfo.Name)
        | _ -> failwith "Invalid property expression"

    let twoWay (description: MvxFluentBindingDescription<'TTarget, 'TSource>) =
        description.TwoWay()

    let oneWay (description: MvxFluentBindingDescription<'TTarget, 'TSource>) =
        description.OneWay()

    let oneWayToSource (description: MvxFluentBindingDescription<'TTarget, 'TSource>) =
        description.OneWayToSource()

    let oneTime (description: MvxFluentBindingDescription<'TTarget, 'TSource>) =
        description.OneTime()
    
    let mode (bindingMode: MvxBindingMode) (description: MvxFluentBindingDescription<'TTarget, 'TSource>) =
        description.Mode(bindingMode)

    let toTarget
        (targetPropertyName: string)
        (description: MvxFluentBindingDescription<'TTarget, 'TSource>)  =
        description.To(targetPropertyName)

    let toExpression<'TTarget, 'TSource, 'T
        when 'TTarget : not struct
        and 'TSource : not struct
        and 'T : not struct>
        (quotation: Quotations.Expr)
        (description: MvxFluentBindingDescription<'TTarget, 'TSource>) =
        
        match quotation with
        | PropertyGet(_, propertyInfo, _) -> description.To(propertyInfo.Name)
        | _ -> failwith "Invalid property expression"

    let apply (set: MvxFluentBindingDescriptionSet<'TOwningTarget, 'TSource>) =
        set.Apply()