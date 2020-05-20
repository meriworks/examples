# Overview
This example shows how to use the Display Channel support in the ImageVault Episerver addon to render a `<picture>` element with multiple image sources for different screen sizes. The example is a custom MVC display template that can easily be extended to suit your specific needs.

The resulting element looks like this:

```
<picture>
    <source media="(max-width: 400px)" srcset="https://imagevault-url.app/publishedmedia/mobileconversionid/image.jpg">
    <source media="(max-width: 768px)" srcset="https://imagevault-url.app/publishedmedia/laptopconversionid/image.jpg">
    <img src="https://imagevault-url.app/publishedmedia/mainconversionid/image.jpg" title="A good title">
</picture>
```

## Requirements
* Episerver CMS with configured Display Channels (this example uses two channels, `Mobile` and `Small Laptop`)
* At least version xx of the ImageVault.EPiServer nuget package (TODO)

## How to use
Place `PictureMediaReference.cshtml` in your display template shared views folder (Views/Shared/DisplayTemplates) and use it to render any MediaReference from your view:

```
@Html.PropertyFor(m => m.MyMedia, "PictureMediaReference", new { title = "A good title" })
```

## Further reading
* [Episerver Display Channels](https://world.episerver.com/documentation/developer-guides/CMS/rendering/display-channels/ "Episerver Display Channels")
* [ImageVault Display Channel documentation (TODO)](# "ImageVault Display Channel documentation (TODO")
* [HTML \<picture\> element](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/picture "HTML <picture> element")
