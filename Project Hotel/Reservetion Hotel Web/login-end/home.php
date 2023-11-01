<!DOCTYPE html>
<html lang="en">
<head>
    <title>Hotel Reservation</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css">
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.4/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
    <link rel="stylesheet" href="home.css">
    <style>
    .form-check-input[type="radio"] {
        display: inline-block;
        margin-right: 10px;
        margin-top: 7px;
    }
    .form-check-label {
        display: inline-block;
        margin-right: 5px;
        margin-top: 7px;
    }

    /* glowing fieldset */
    @import url("https://fonts.googleapis.com/css?family=Raleway");

    :root{
      --glow-color: hsl(186 100% 69%);
    }
    *{
      box-sizing: border-box;
    }
    .glowing-fieldset{
      position: relative;
      color: var(--glow-color);
      cursor: pointer;
      padding: 0.35em 1em;
      border: 0.15em solid var(--glow-color);
      border-radius: 0.45em;
      perspective: 2em;
      -webkit-box-shadow: inset 0px 0px 0.5em 0px var(--glow-color),
        0px 0px 0.5em 0px var(--glow-color);
      -moz-box-shadow: inset 0px 0px 0.5em 0px var(--glow-color),
        0px 0px 0.5em 0px var(--glow-color);
      box-shadow: inset 0px 0px 0.5em 0px var(--glow-color),
        0px 0px 0.5em 0px var(--glow-color);
      animation: border-flicker 2s linear infinite;
    }

    .faulty-letter{
      opacity: 0.5;
      animation: faulty-flicker 2s linear infinite;
    }
    .glowing-fieldset::before{
      content: "";
      position: absolute;
      top: 0;
      bottom: 0;
      left: 0;
      right: 0;
      opacity: 0.7;
      filter: blur(1em);
      transform: translateY(120%) rotateX(95deg) scale(1, 0.35);

      pointer-events: none;
    }
    .glowing-fieldset::after {
      content: "";
      position: absolute;
      top: 0;
      left: 0;
      right: 0;
      bottom: 0;
      opacity: 0;
      z-index: -1;
      box-shadow: 0 0 2em 0.2em var(--glow-color);
      transition: opacity 100ms linear;
    }

    @keyframes faulty-flicker{
      0%{
        opacity: 0.1;
      }
      2%{
        opacity: 0.1;
      }
      4%{
        opacity: 0.5;
      }
      19%{
        opacity: 0.5;
      }
      21%{
        opacity: 0.1;
      }
      23%{
        opacity: 1;
      }
      80%{
        opacity: 0.5;
      }
      83%{
        opacity: 0.4;
      }
      87%{
        opacity: 1;
      }
    }
    @keyframes text-flicker{
      0%{
        opacity: 0.1;
      }
      2%{
        opacity: 1;
      }
      8%{
        opacity: 0.1;
      }
      9% {
        opacity: 1;
      }
      12% {
        opacity: 0.1;
      }
      20% {
        opacity: 1;
      }
      25%{
        opacity: 0.3;
      }
      30%{
        opacity: 1;
      }

      70%{
        opacity: 0.7;
      }
      72%{
        opacity: 0.2;
      }

      77%{
        opacity: 0.9;
      }
      100%{
        opacity: 0.9;
      }
    }
    @keyframes border-flicker{
      8%{
        opacity: 1;
      }
      70%{
        opacity: 0.7;
      }
      100%{
        opacity: 1;
      }
    }
    </style>

</head>
<body>
<legend>الحجـز الفنــدقي</legend>    
<fieldset class="glowing-fieldset">
<div class="container">
    <form method="POST">
        <div class="row">
            <div class="col-md-6">
                <legend>بيانات النزيل</legend>
                <div class="form-group">
                    <label for="firstname">اسم النزيل:</label>
                    <input type="text" class="form-control" id="firstname" name="fullname" maxlength="10" required>
                </div>
                <div class="form-group">
                    <label for="age">العمر:</label>
                    <input type="number" class="form-control" id="age" name="age" min="18" max="90" required>
                </div>
                <div class="form-group">
                    <label for="nationality">الجنسية:</label>
                    <input type="text" class="form-control" id="nationality" name="nationality" required>
                </div>
                <div class="form-group">
                    <label for="id_number">رقم الهوية:</label>
                    <input type="number" class="form-control" id="id_number" name="id_number" required>
                </div>
                <div class="form-group">
                    <label for="numberphone">رقم الهاتف:</label>
                    <input type="number" class="form-control" id="numberphone" name="numberphone" required>
                </div>
                <div class="form-group">
                <label for="date_in">تاريخ الدخول:</label>
                    <input type="date" class="form-control" id="date_in" name="date_in" required>
                </div>
                <div class="form-group">
                    <label for="date_out">تاريخ الخروج:</label>
                    <input type="date" class="form-control" id="date_out" name="date_out" required>
                </div>
            </div>
            <div class="col-md-6">
                <fieldset>
                    <legend>بيانات الزوجة</legend>
                    <div class="form-group">
                        <label for="wifefirstname">اسم الزوجة:</label>
                        <input type="text" class="form-control" id="wifefirstname" name="wife_fullname" maxlength="10">
                    </div>
                    <div class="form-group">
                        <label for="id_number_wife">رقم هوية الزوجة:</label>
                        <input type="number" class="form-control" id="id_number_wife" name="id_number_wife">
                    </div>
                </fieldset>
                <div class="form-group">
                    <label for="num_people">عدد الأفراد الكلي:</label>
                    <input type="number" class="form-control" id="num_people" name="num_people">
                </div>
                <fieldset>
                    <div class="form-group">
                        <label for="last_12">أقل من 12</label>
                        <input type="number" class="form-control" id="last_12" name="last_12" placeholder="عدد الأشخاص">
                    </div>
                    <div class="form-group">
                        <label for="between_12">بين 2 و 12</label>
                        <input type="number" class="form-control" id="between_12" name="between_12" placeholder="عدد الأشخاص">
                    </div>
                    <div class="form-group">
                        <label for="more_12">أكثر من 12</label>
                        <input type="number" class="form-control" id="more_12" name="more_12" placeholder="عدد الأشخاص">
                    </div>
                </fieldset>
                <div class="form-group">
                    <label>نوع الغرفة:</label><br>
                    <div class="form-check form-check-inline">
                        <input type="radio" class="form-check-input" name="romtype" id="single" value="single">
                        <label class="form-check-label" for="single">مفردة</label>
                    </div>
                    <div class="form-check form-check-inline">
                        <input type="radio" class="form-check-input" name="romtype" id="dual" value="dual">
                        <label class="form-check-label" for="dual">مزدوجة</label>
                    </div>
                    <div class="form-check form-check-inline">
                        <input type="radio" class="form-check-input" name="romtype" id="third" value="third">
                        <label class="form-check-label" for="third">ثلاثية</label>
                    </div>
                    <div class="form-check form-check-inline">
                        <input type="radio" class="form-check-input" name="romtype" id="sweet" value="sweet">
                        <label class="form-check-label" for="sweet">سويت</label>
                    </div>
                </div>
            </div>
        </div>
        <div class="btn-group">
            <button type="submit" class="btn btn-primary" name="insert" >حجــز</button>
            
        </div>
    </form>
</div>
</fieldset>    
</body>
</html>


<?php
$Connitcion = odbc_connect('DataWep','','');
function GetData(){
  $data = array();
  $data[1] = $_POST['fullname'];
  $data[2] = $_POST['age'];
  $data[3] = $_POST['nationality'];
  $data[4] = $_POST['id_number'];
  $data[5] = $_POST['numberphone'];
  $data[6] = $_POST['date_in'];
  $data[7] = $_POST['date_out'];
  $data[8] = $_POST['wife_fullname'];
  $data[9] = $_POST['id_number_wife'];
  $data[10] = $_POST['num_people'];
  $data[11] = $_POST['last_12'];
  $data[12] = $_POST['between_12'];
  $data[13] = $_POST['more_12'];
  $data[14] = $_POST['romtype'];
  return $data;
}
if(isset($_POST['insert'])){
  $info = GetData();
  $insert = "INSERT INTO [T_CUS_DATA] ([fullname]
  ,[age]
  ,[nationality]
  ,[id_number]
  ,[numberphone]
  ,[date_in]
  ,[date_out]
  ,[wifefullname]
  ,[id_number_wife]
  ,[num_people]
  ,[last_12]
  ,[between_12]
  ,[more_12]
  ,[rom_type]) VALUES ('$info[1]', '$info[2]', '$info[3]', '$info[4]', '$info[5]', '$info[6]', '$info[7]', '$info[8]', '$info[9]', '$info[10]', '$info[11]', '$info[12]', '$info[13]', '$info[14]')";
  $result = odbc_exec($Connitcion,$insert);
  require"revarsation.php";
}
?>
