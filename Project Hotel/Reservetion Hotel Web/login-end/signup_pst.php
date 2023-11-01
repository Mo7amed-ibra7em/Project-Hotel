<?php
$firstname=$_POST['firstname'];
$lastname=$_POST['lastname'];
$number=$_POST['number'];
$email=$_POST['email'];
$password=$_POST['password'];
$conn=new mysqli('localhost','root','','project');
if($conn->connect_error){
    die('connection failed :'.mysqli_connect_errno().')' .mysqli_connect_error());
}else{
   $sql="INSERT INTO coustomer(firstname,lastname,number,email,password)
   values ('$firstname','$lastname','$number','$email','$password')";
   
   if($conn->query($sql)){
header('location:signtrue.php');
   }
   else{
    echo "ERROR".$sql ."<br>".$conn->error;
   }
   $conn->close();
}
?>