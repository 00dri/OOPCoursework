<?php

function __autoload($className)
{
    include_once("./" . $className . ".class.php");
}

$room = new SingleRoom(12,250);
echo $room;

$guestOne = new Guest("Pesho", "Peshov", 12548789);
$reservationOne = new Reservation("10-10-2015", "20-10-2015", $guestOne);
echo " ||| Reservation: ";
echo $reservationOne;