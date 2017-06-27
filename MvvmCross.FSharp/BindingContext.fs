namespace MvvmCross.FSharp

open MvvmCross.Binding.BindingContext

module BindingContext = 
    let bind<'TOwningTarget, 'TSource, 'TChildTarget 
        when 'TOwningTarget : not struct 
        and 'TOwningTarget :> IMvxBindingContextOwner
        and 'TChildTarget : not struct>
        (childTarget: 'TChildTarget)   
        (set: MvxFluentBindingDescriptionSet<'TOwningTarget, 'TSource>) =
        set.Bind(childTarget)

    let forProperty 
        (targetPropertyName: string)
        (description: MvxFluentBindingDescription<'TTarget, 'TSource>) =
        description.For(targetPropertyName)
   
    let toTarget 
        (targetPropertyName: string)
        (description: MvxFluentBindingDescription<'TTarget, 'TSource>)  =
        description.To(targetPropertyName)

    let apply (set: MvxFluentBindingDescriptionSet<'TOwningTarget, 'TSource>) =
        set.Apply()