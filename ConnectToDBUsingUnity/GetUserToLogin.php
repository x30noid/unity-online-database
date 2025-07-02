<?php
	require 'settings.php';
	require 'connection.php';
	require 'ExecuteQuery.php';

	$login = $_POST['login'];
	$password = $_POST['password'];

	if(!isset($login) && !isset($password))
	{
		echo "Problema com os dados passados como parametro";
	}
	else
	{
		$query = ExecuteQuery("SELECT * FROM user WHERE login = '$login'");



		if(mysqli_num_rows($query) > 0)
		{
			while ($row = mysqli_fetch_assoc($query)) 
			{
				if($row['password'] === md5($password))
				{
					echo "Your login is ".$row['login']."| your password is ".$password."| your email is ".$row['email'];
				}
			}
		}
	}
?>