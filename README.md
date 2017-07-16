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

## What's next?

- Publishing to NuGet
- Use FAKE to automate publishing
- Strongly typed binding names for the bindings provided out-of-the-box
- Make the DSL even better
