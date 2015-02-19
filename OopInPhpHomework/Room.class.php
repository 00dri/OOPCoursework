<?php
require_once("iReservable.class.php");

abstract class Room implements iReservable
{
	private $reservations = [];
	private $roomType;
	private $hasRestroom;
	private $hasBalcony;
	private $bedCount;
	private $roomNumber;
	private $extras = [];
	private $price;
	
	public function __construct($bedCount, $roomType, $hasRestroom, $hasBalcony, $price, $roomNumber)
	{
		$this->bedCount = $bedCount;
		$this->roomType = $roomType;
		$this->hasRestroom = $hasRestroom;
        $this->hasBalcony = $hasBalcony;
        $this->roomNumber = $roomNumber;
        $this->price = $price;
	}
	
	public function getBedCount()
	{
		return $this->bedCount;
	}
	
	public function getRoomNumber()
	{
		return $this->roomNumber;
	}
	
    public function getRoomType()
    {
        return $this->roomType;
    }

    public function getPrice()
    {
        return $this->price;
    }
  
    public function hasBalcony()
    {
        return $this->hasBalcony;
    }

    public function hasRestroom()
    {
        return $this->hasRestroom;
    }
	
    public function addExtras($extras)
    {
        $this->extras[] = $extras;
    }
	
    public function  hasExtra($extra)
    {
        return in_array($extra, $this->extras);
    }
	
    public function __toString()
    {
        $resultString = "Room number: $this->roomNumber - Type: $this->roomType - Number of beds: $this->bedCount\n";
        foreach ($this->reservations as $reservation) {
            $resultString .= $reservation->__toString() . PHP_EOL;
        }
        return $resultString;
    }
	
    public function addReservation($reservation)
    {
        $this->$reservation;
        $this->reservations[] = $reservation;
    }
	
	function removeReservation($reservation)
	{
		$this->$reservation;
		foreach (array_keys($this->reservations, $reservation, true) as $key) {
    		unset($reservations[$key]);
		}
	}
}
