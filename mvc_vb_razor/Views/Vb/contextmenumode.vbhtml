<!DOCTYPE html>
<html>
<head>
    <title>RichTextEditor - ContextMenu mode</title>
    <link rel="stylesheet" href="/Content/example.css" type="text/css" />
</head>
<body>
    @Code Html.BeginForm()End Code
    <h1>
        Context menu customization</h1>
    <p>
        RichTextEditor is a context sensitive application, it is aware of it's context and
        acts accordingly. There are many ways to control the context menu behaviors within
        RichTextEditor:
    </p>
    <div>
        <div>
            <span id="MainContent_rbl_type">
                <input id="MainContent_rbl_type_0" type="radio" name="SelectType" value="" checked="checked"
                    onclick="MvcSubmit();" /><label for="MainContent_rbl_type_0">Default</label>
                <input id="MainContent_rbl_type_1" type="radio" name="SelectType" value="Simple"
                    onclick="MvcSubmit();" /><label for="MainContent_rbl_type_1">Simple</label>
                <input id="MainContent_rbl_type_2" type="radio" name="SelectType" value="Minimal"
                    onclick="MvcSubmit();" /><label for="MainContent_rbl_type_2">Minimal</label></span>
            <script type="text/javascript">
                var ipts = document.getElementsByName("SelectType");
                var mode = '@ViewBag._mode' || "";
                if (mode) {
                    for (var i = 0; i < ipts.length; i++) {
                        if (ipts[i].value == mode) {
                            ipts[i].checked = true;
                            break;
                        }
                    }
                }
                function MvcSubmit() {
                    document.getElementById('btn_sumbit').click();
                }
            </script>
            <button id="btn_sumbit" style="display: none;" type="submit">
                Submit</button>
        </div>
        <br />
        @Html.Raw(ViewBag.Editor)
    </div>
    @Code Html.EndForm()End Code
</body>
</html>
