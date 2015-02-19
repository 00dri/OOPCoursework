<?php
require_once "Room.class.php";

class Bedroom extends Room
{
    const BED_COUNT = 2;
	
    function __construct($roomNumber, $price)
    {
        parent::__construct(Bedroom::BED_COUNT, RoomType::GOLD, TRUE, TRUE, $price, $roomNumber);
        $this->addExtras(Extra::TV);
        $this->addExtras(Extra::AIR_CONDITIONER);
        $this->addExtras(Extra::REFRIGERATOR);
        $this->addExtras(Extra::MINI_BAR);
        $this->addExtras(Extra::BATHTUB);
    }
}
