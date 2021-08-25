var tags = document.querySelector("#tags")
var tagify = new Tagify(tags, {
    originalInputValueFormat: valuesArr => valuesArr.map(item => item.value).join(',')
})

var comments = document.querySelectorAll(".add-comment")
comments.forEach(c => c.addEventListener("click", e => {
    e.preventDefault()
    e.target.parentElement.querySelector("input").classList.toggle("comment")
    e.target.parentElement.querySelector("button").classList.toggle("comment")
}))