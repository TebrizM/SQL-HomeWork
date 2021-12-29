$(function () {
  // $(document).on('click',".accordion-button", function(){
  //    console.log( $(this).parent().next().slideToggle());

  $(document).on("click", ".accordion-button", function () {
      if ($(".active")[0] != $(this).parent().next()[0]) {
          $(".active").slideUp(1000, function () {
              $(this).removeClass("active");
            });
            $(this)
            .parent()
            .next()
            .slideDown(1000, function () {
                $(this).addClass("active");
            });
            
            
    }
    else{
        $(".active").slideUp(1000, function () {
            $(this).removeClass("active");
          });
    }
  });
});
