$(document).ready(function(){
  /*flash*/
  $(".f").hover
  (
    function()
    {
    $(".f").css("color","rgb(255, 110, 7)");
    }
    ,
    function()
    {
    $(".f").css("color","white");
    }
    );

/*heroes*/
  $(".h").hover
  (
    function()
    {
    $(".h").css("color","rgb(218, 55, 55)");
    }
    ,
    function()
    {
    $(".h").css("color","white");
    }
  );

/*vampire*/
  $(".v").hover
  (
    function()
    {
    $(".v").css("color","red");
    }
    ,
    function()
    {
    $(".v").css("color","white");
    }
  );

/*legend*/
  $(".le").hover
  (
    function()
    {
    $(".le").css("color","rgb(7, 204, 211)");
    }
    ,
    function()
    {
    $(".le").css("color","white");
    }
  );
/*arrow*/
  $(".a").hover
  (
    function()
    {
    $(".a").css("color","rgb(21, 187, 17)");
    }
    ,
    function()
    {
    $(".a").css("color","white");
    }
  );
/*lost*/
  $(".lo").hover
  (
    function()
    {
    $(".lo").css("color","rgb(0, 100, 255)");
    }
    ,
    function()
    {
    $(".lo").css("color","white");
    }
  );

/*el navbaar*/
  $(".open").click(function()
  {
  $(".open").fadeOut(800,function()
  {
  $(".box1").fadeIn(800,function()
  {
  $(".box2").fadeIn(800,function()
  {
  $(".box3").fadeIn(900,function()
  {
  $(".box4").fadeIn(900,function()
  {
  $(".box5").fadeIn(900,function()
  {
  $(".box6").fadeIn(900,function()
  {
	$(".box7").fadeIn(1200)
  });
  });
  });
  });
  });
  });
  });
  });

});
