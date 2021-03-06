<!DOCTYPE html>
<html>
<head>
    <title>RichTextEditor - Filtering HTML code</title>
    <link rel="stylesheet" href="/Content/example.css" type="text/css" />
</head>
<body>
    @Code Html.BeginForm()End Code
    <h1>
        How to Filtering HTML code in Rich Text Editor?</h1>
    <p>
        The new Filtering HTML code functionality in Rich Text Editor 8 allows you to accept
        HTML input from your users, filter it to make sure it contains only an allowed set
        of tags, attributes and values and then display it without leaving yourself open
        to XSS holes.</p>
    <p>
        The possible options are:</p>
    <ul>
        <li>TagWhiteList - Allows you set a list of html tags that will not be removed from
            content sources. </li>
        <li>TagBlackList - Allows you set a list of html tags that will be removed from content
            sources. </li>
        <li>AttrWhiteList - Allows you set a list of html attributes that will not be removed
            from content sources. </li>
        <li>AttrBlackList - Allows you set a list of html attributes that will be removed from
            content sources. </li>
        <li>StyleWhiteList - Allows you set a list of style attributes that will not be removed
            from content sources. </li>
        <li>StyleBlackList - Allows you set a list of style attributes that will be removed
            from content sources.</li>
        <li>No HTML - All the HTML code will be filtered.</li>
        <li>Full HTML - The filtering is disabled. Usually this option can be used for for trusted
            users.</li>
    </ul>
    <div>
        <div>
            <span id="MainContent_rbl_type">
                <input id="MainContent_rbl_type_0" type="radio" name="SelectType" value="" checked="checked"
                    onclick="MvcSubmit();" /><label for="MainContent_rbl_type_0">Default</label>
                <input id="MainContent_rbl_type_1" type="radio" name="SelectType" value="black" onclick="MvcSubmit();" /><label
                    for="MainContent_rbl_type_1">Black list : div</label>
                <input id="MainContent_rbl_type_2" type="radio" name="SelectType" value="white" onclick="MvcSubmit();" /><label
                    for="MainContent_rbl_type_2">White list : embed</label>
                <input id="MainContent_rbl_type_3" type="radio" name="SelectType" value="no" onclick="MvcSubmit();" /><label
                    for="MainContent_rbl_type_3">No html</label>
                <input id="MainContent_rbl_type_4" type="radio" name="SelectType" value="full" onclick="MvcSubmit();" /><label
                    for="MainContent_rbl_type_4">Full html</label></span>
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
                var editor;
                function RichTextEditor_OnLoad(rteeditor) {

                    var c = rteeditor.GetText();
                    if (!c) {
                        document.getElementById("result").innerHTML = "";
                        return;
                    }
                    document.getElementById("result").innerHTML = c.replace(/</g, "&lt;");
                }
            
            </script>
        </div>
        <br />
        @Html.Raw(ViewBag.Editor)
        <br />
        <button id="btn_sumbit" type="submit">
            Submit</button>
    </div>
    <br />
    <div>
        <h3>
            Result html code:</h3>
        <div id="result">
        </div>
    </div>
    @Code Html.EndForm()End Code
</body>
</html>
