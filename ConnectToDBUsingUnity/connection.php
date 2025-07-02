<?php
    function DBConnect()
    {
        $conn = mysqli_connect(DB_HOSTNAME, DB_USERNAME, DB_PASSWORD, DB_DATABASE) or die(mysqli_connect_error());
        return $conn;
    }

    function DBClose($conn)
    {
        mysqli_close($conn) or die(mysqli_error($conn));
    }
?>