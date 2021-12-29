$(function(){
    $(document).on("click", ".button-logo", function (){
       let index = $(this).attr("id");
       console.log(this);
       $(".content").removeClass("active")
       $(`.${index}-content`).addClass("active")
    })
})
