namespace MvvmCross.FSharp.Droid


open Android.Preferences
open Android.Views
open Android.Widget
open MvvmCross.Binding.Droid.Views

open MvvmCross.Binding.BindingContext
module PropertyBinding =

    let forClick<'TView, 'TSource when 'TView :>  View and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Click")

    let forText<'TView, 'TSource when 'TView :>  TextView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Text")

    let forTextFormatted<'TView, 'TSource when 'TView :>  TextView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("TextFormatted")

    let forPartialText<'TView, 'TSource when 'TView :>  MvxAutoCompleteTextView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("PartialText")

    let forSelectedObject<'TView, 'TSource when 'TView :>  MvxAutoCompleteTextView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("SelectedObject")

    let forChecked<'TView, 'TSource when 'TView :>  CompoundButton and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Checked")

    let forProgress<'TView, 'TSource when 'TView :>  SeekBar and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Progress")

    let forVisible<'TView, 'TSource when 'TView :>  View and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Visible")

    let forHidden<'TView, 'TSource when 'TView :>  View and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Hidden")

    let forBitmap<'TView, 'TSource when 'TView :>  ImageView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Bitmap")

    let forDrawable<'TView, 'TSource when 'TView :>  ImageView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Drawable")

    let forDrawableId<'TView, 'TSource when 'TView :>  ImageView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("DrawableId")

    let forDrawableName<'TView, 'TSource when 'TView :>  ImageView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("DrawableName")

    let forResourceName<'TView, 'TSource when 'TView :>  ImageView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("ResourceName")

    let forAssetImagePath<'TView, 'TSource when 'TView :>  ImageView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("AssetImagePath")

    let forSelectedItem<'TView, 'TSource when 'TView :>  MvxSpinner and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("SelectedItem")

    let forSelectedItemPosition<'TView, 'TSource when 'TView :>  AdapterView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("SelectedItemPosition")

    let forRating<'TView, 'TSource when 'TView :>  RatingBar and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Rating")

    let forLongClick<'TView, 'TSource when 'TView :>  View and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("LongClick")

    let forTextFocus<'TView, 'TSource when 'TView :>  EditText and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("TextFocus")

    let forQuery<'TView, 'TSource when 'TView :>  SearchView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Query")

    let forValue<'TView, 'TSource when 'TView :>  Preference and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Value")
