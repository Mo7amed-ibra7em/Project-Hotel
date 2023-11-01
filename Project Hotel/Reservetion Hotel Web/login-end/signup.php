<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>signup.com</title>
    <link rel="stylesheet" href="signup.css">
</head>
<body>
  
  
    <form action="signup_pst.php" method="post">
    <div class="login_form_container">
        <div class="login_form">
          <img class="ima1" src="picturs/house.png" width="50px" height="50px">
        
          <h2>إنشاء الحساب</h2>
          <div class="input_group">
            <i class="fa fa-user"></i>
            <img  src="picturs/user2.png" width="25px" height="25px" >
            <input
              type="text"
              placeholder="الاسم الاول"
              required
              class="input_text"
              name="firstname"
              autocomplete="off"
            />
          </div>
          <div class="input_group">
            <i class="fa fa-unlock-alt"></i>
            <img src="picturs/user2.png" width="25px" height="25px">
           
            <input
              type="text"
              placeholder="الاسم الاخير"
              required
              name="lastname"
              class="input_text"
              autocomplete="off"
            />
          </div>
          <div class="input_group">
            <i class="fa fa-unlock-alt"></i>
            <img src="picturs/22.png" width="25px" height="25px">
            <input
            type="number"
            placeholder="رقم الهاتف"
            class="input_text"
            autocomplete="off"
            name="number"
            />
          </div>
          <div class="input_group">
            <i class="fa fa-unlock-alt"></i>
            <img src="picturs/11.png" width="25px" height="25px">
            <input
            type="email"
            placeholder="@البريد الإلكنروني"
            class="input_text"
            name="email"
            autocomplete="off"
            />
          </div>
          <div class="input_group">
            <i class="fa fa-unlock-alt"></i>
            <img src="picturs/Lock2.png" width="25px" height="25px">
            <input
              type="password"
              required
              name="password"
              placeholder="كلمة المرور"
              class="input_text"
              autocomplete="off"
            />
          </div>
       
          
          <div class="input_group" id="login_button"></div>
        
         
      <input class="sub1" type="submit" value="تسجيل الدخول" name="submit" >
          </div>
        </table>
        </div>
      </div>
    </form>
</body>
</html>