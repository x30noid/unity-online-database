<?php
	require 'settings.php';
	require 'connection.php';
	require 'ExecuteQuery.php';

	$login = $_POST['login'];
	$password = md5($_POST['password']);
	$email = $_POST['email'];

	if(!isset($login) || !isset($password) || !isset($email))
	{
		echo "Problema com os dados passados como parametro";
	}
	else
	{
		$query = ExecuteQuery("INSERT INTO user(login, password, email) VALUES ('$login', '$password', '$email')");
		echo "Conexão Efetuada";
	}
	
?>