<?php
class Guest 
{
	private $firstName;
	private $lastName;
	private $id;
	
    function __construct($firstName, $lastName, $id)
    {
        $this->firstName = $firstName;
        $this->lastName = $lastName;
        $this->id = $id;
    }

    public function setFirstName($firstName)
    {
        $this->firstName = $firstName;
    }
 
    public function getFirstName()
    {
        return $this->firstName;
    }
	
    public function setLastName($lastName)
    {
        $this->lastName = $lastName;
    }

    public function getLastName()
    {
        return $this->$lastName;
    }

    public function setId($id)
    {
        $this->id = $id;
    }

    public function getId()
    {
        return $this->id;
    }
	
    function __toString()
    {
        return $this->firstName . " " . $this->lastName .  " -  EGN: " . $this->id;
    }
}
