<!DOCTYPE html>
<html>
<head>
    <title>RichTextEditor - Extract plain text</title>
    <link rel="stylesheet" href="/Content/example.css" type="text/css" />
</head>
<body>
    <script type="text/javascript">
        var editor;
        function RichTextEditor_OnLoad(rteeditor) {
            editor = rteeditor;
            var content = "@ViewBag._content";
            if (!content) {
                setTimeout(function () {
                    editor.SetText(document.getElementById("div_template").innerHTML);
                }, 1000);
                return;
            }
        }
    </script>
    @Code Html.BeginForm()End Code
    <h1>
        Extract plain text example</h1>
    <p>
        This sample demonstrates retrieving the RichTextEditor HTML content in the plain
        text format. If you want to store the document text in a database which is searchable,
        you can use the output of this property to create an HTML-free copy for indexing.
    </p>
    <div>
        @Html.Raw(ViewBag.Editor)
        <br />
        <button id="btn_sumbit" type="submit">
            Submit</button>
    </div>
    <br />
    <div>
        <h3>
            Result html:</h3>
        <div>
            @ViewBag._content
        </div>
    </div>
    <div id="div_template" style="display: none;">
        <table cellspacing="4" cellpadding="4" border="0">
            <tbody>
                <tr>
                    <td>
                        <p>
                            <img src="http://www.richtexteditor.com/uploads/j0262681.jpg" alt="" /></p>
                    </td>
                    <td>
                        <p>
                            When your algorithmic and programming skills have reached a level which you cannot
                            improve any further, refining your team strategy will give you that extra edge you
                            need to reach the top. We practiced programming contests with different team members
                            and strategies for many years, and saw a lot of other teams do so too.
                        </p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p>
                            <img src="http://www.richtexteditor.com/uploads/PH02366J.jpg" alt="" /></p>
                    </td>
                    <td>
                        <p>
                            From this we developed a theory about how an optimal team should behave during a
                            contest. However, a refined strategy is not a must: The World Champions of 1995,
                            Freiburg University, were a rookie team, and the winners of the 1994 Northwestern
                            European Contest, Warsaw University, met only two weeks before that contest.
                        </p>
                    </td>
                </tr>
            </tbody>
        </table>
        <br />
    </div>
    @Code Html.EndForm()End Code
</body>
</html>
