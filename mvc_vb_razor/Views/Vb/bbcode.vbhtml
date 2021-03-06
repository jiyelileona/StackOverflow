<!DOCTYPE html>
<html>
<head>
    <title>RichTextEditor - BBCode</title>
    <link rel="stylesheet" href="/Content/example.css" type="text/css" />
</head>
<body>
    @Code Html.BeginForm()End Code
    <h1>
        Output BBCode</h1>
    <p>
        This sample shows how to configure Rich Text Editor to output BBCode format instead
        of HTML. BBCode syntax is commonly used by forums and comment systems.
    </p>
    <div>
        @Html.Raw(ViewBag.Editor)
        <br />
        <button type="submit">
            submit</button>
    </div>
    <br />
    <div>
        <h3>
            Result html:</h3>
        <div>
            @ViewBag.BBCode
        </div>
    </div>
    @Code Html.EndForm()End Code
</body>
</html>
