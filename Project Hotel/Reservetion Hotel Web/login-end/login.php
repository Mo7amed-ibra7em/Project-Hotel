
<!DOCTYPE html>
<html lang="en">
  <head >
    
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Login.com</title>
    <link rel="stylesheet" href="login.css" />
  </head>
  <body >
    
    <div class="login_form_container">
      <div class="login_form">
        <img class="logo" src="picturs/house.png" width="50px" height="50px" >
        
        <h2 >تسجيل الدخول</h2>
        <div class="input_group">
          <i class="fa fa-user"></i>
          <img src="picturs/user2.png" width="25px" height="25px">
          <form  action="checklogin.php" method="post">
          <input
            type="email"
            placeholder="اسم المستخدم"
            class="input_text"
            autocomplete="off"
            name="username"
          />
        </div>
        <div class="input_group">
          <i class="fa fa-unlock-alt"></i>
          <img src="picturs/Lock2.png" width="25px" height="25px">
          <input
            type="password"
            placeholder="كلمة المرور"
            class="input_text"
            autocomplete="off"
            name="password"
          />
        </div>
        <div class="button_group" id="login_button">
          <input type="submit" name="sub1" value="تسجيل الدخول" id="sub1">
        </div>
        <div class="fotter" >
          
          
          <a  href="signup.php">إنشاء حساب</a>
          
        </div>
       
      </div>
    </div>
   
 
    <script src="login.js"></script>
</form>
  </body>
</html>
