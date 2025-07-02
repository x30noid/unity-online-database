<?php
	function ExecuteQuery($sql)
	{
		$conn = DBConnect();
		$query = mysqli_query($conn, $sql) or die(mysqli_error($conn));
		DBClose($conn);
		return $query;
	}
?>