<?php

session_start();
require('connictions.php');
if($_SERVER['REQUEST_METHOD']=="POST")
{
  $user=$_POST['username'];
  $pass=$_POST['password'];
  if(!empty($user) && !empty($pass) && !is_numeric($user))
  {
    $query="select * from coustomer where email='$user' && password ='$pass'";
    $result=mysqli_query($conn,$query);
    if($result)
    {
      if($result && mysqli_num_rows($result)>0)
      {
        $user_data=mysqli_fetch_assoc($result);
        if($user_data['password']==$pass)
        {
        header("location:home.php");
        die;
        }
        }
      }
      
        echo "<script type='text/javascript'> alert('اسم المستخدم أو كلمة المرور خطأ')</script>";
   require "login.php";
      
    }
    else{

      echo "<script type='text/javascript'> alert('اسم المستخدم أو كلمة المرور خطأ')</script>";
      require "login.php";
    }
  }

?>