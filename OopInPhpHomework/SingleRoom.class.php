<?php
require_once "Room.class.php";

 class SingleRoom extends Room 
 {	
    const BED_COUNT = 1;
	
    function __construct($roomNumber, $price)
    {
        parent::__construct(SingleRoom::BED_COUNT, RoomType::STANDARD, TRUE, FALSE, $price, $roomNumber);
        $this->addExtras(Extra::TV);
        $this->addExtras(Extra::AIR_CONDITIONER);
    }
 }

