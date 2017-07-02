# MvvmCross.FSharp
:nail_care: Extensions to make MvvmCross bindings more F#-ish

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
|> toExpression <@ this.ViewModel.MyList @>
|> ignore

set
|> bind source
|> forExpression <@ source.SelectionChangedCommand @>
|> toExpression <@ this.ViewModel.MyCommand @>
|> ignore
```

`<|` ALSO PIPES `|>`

## What's next?

- Publishing to NuGet
- Use FAKE to automate publishing
- Strongly typed binding names for the bindings provided out-of-the-box
- Bindings DSL based on operators ([WIP](https://github.com/willsb/MvvmCross.FSharp/blob/master/MvvmCross.FSharp/BindingOperators.fs))
