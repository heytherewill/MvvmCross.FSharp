namespace MvvmCross.FSharp.iOS

open UIKit
open MvvmCross.Binding.BindingContext
module PropertyBinding =

    let forTouchDown<'TView, 'TSource when 'TView :>  UIControl and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("TouchDown")

    let forTouchDownRepeat<'TView, 'TSource when 'TView :>  UIControl and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("TouchDownRepeat")

    let forTouchDragInside<'TView, 'TSource when 'TView :>  UIControl and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("TouchDragInside")

    let forTouchUpInside<'TView, 'TSource when 'TView :>  UIControl and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("TouchUpInside")

    let forValueChanged<'TView, 'TSource when 'TView :>  UIControl and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("ValueChanged")

    let forPrimaryActionTriggered<'TView, 'TSource when 'TView :>  UIControl and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("PrimaryActionTriggered")

    let forEditingDidBegin<'TView, 'TSource when 'TView :>  UIControl and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("EditingDidBegin")

    let forEditingChanged<'TView, 'TSource when 'TView :>  UIControl and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("EditingChanged")

    let forEditingDidEnd<'TView, 'TSource when 'TView :>  UIControl and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("EditingDidEnd")

    let forEditingDidEndOnExit<'TView, 'TSource when 'TView :>  UIControl and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("EditingDidEndOnExit")

    let forAllTouchEvents<'TView, 'TSource when 'TView :>  UIControl and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("AllTouchEvents")

    let forAllEditingEvents<'TView, 'TSource when 'TView :>  UIControl and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("AllEditingEvents")

    let forAllEvents<'TView, 'TSource when 'TView :>  UIControl and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("AllEvents")

    let forVisibility<'TView, 'TSource when 'TView :>  UIView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Visibility")

    let forVisible<'TView, 'TSource when 'TView :>  UIView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Visible")

    let forHidden<'TView, 'TSource when 'TView :>  UIActivityIndicatorView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Hidden")

    let forValue<'TView, 'TSource when 'TView :>  UISlider and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Value")

    let forCurrentPage<'TView, 'TSource when 'TView :>  UIPageControl and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("CurrentPage")

    let forSelectedSegment<'TView, 'TSource when 'TView :>  UISegmentedControl and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("SelectedSegment")

    let forDate<'TView, 'TSource when 'TView :>  UIDatePicker and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Date")

    let forShouldReturn<'TView, 'TSource when 'TView :>  UITextField and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("ShouldReturn")

    let forTime<'TView, 'TSource when 'TView :>  UIDatePicker and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Time")

    let forText<'TView, 'TSource when 'TView :>  UILabel and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Text")

    let forLayerBorderWidth<'TView, 'TSource when 'TView :>  UIView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("LayerBorderWidth")

    let forOn<'TView, 'TSource when 'TView :>  UISwitch and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("On")

    let forTitle<'TView, 'TSource when 'TView :>  UIButton and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Title")

    let forDisabledTitle<'TView, 'TSource when 'TView :>  UIButton and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("DisabledTitle")

    let forHighlightedTitle<'TView, 'TSource when 'TView :>  UIButton and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("HighlightedTitle")

    let forSelectedTitle<'TView, 'TSource when 'TView :>  UIButton and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("SelectedTitle")

    let forTap<'TView, 'TSource when 'TView :>  UIView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("Tap")

    let forDoubleTap<'TView, 'TSource when 'TView :>  UIView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("DoubleTap")

    let forTwoFingerTap<'TView, 'TSource when 'TView :>  UIView and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("TwoFingerTap")

    let forTextFocus<'TView, 'TSource when 'TView :>  UITextField and 'TView : not struct and 'TSource : not struct>
        (description: MvxFluentBindingDescription<'TView, 'TSource>) =
        description.For("TextFocus")
