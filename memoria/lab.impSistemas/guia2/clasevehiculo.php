<?php
class Vehiculo{
    private $duenio;
    private $puertas;
    private $ruedas;
    
    protected function set_detalles_vehiculo($duenio,$puertas,$ruedas){
        $this-> duenio=$duenio;
        $this-> puertas=$puertas;
        $this-> ruedas0$ruedas;
    }
    
    function construct(){
        $this->set_detalles_vehiculo('william','4','4');
    }
    
    function destruct(){
        $this->set_detalles_vehiculo('william','4','4');
        print'el objeto ha sido destruido';
    }
    public function caracteristicas():void{
    
    }
}

class Auto extends Vehiculo {
    protected $descapotable;
    protected function set_auto($descapotable){
        $this->descapotable=$descapotable;
    }
    function construct(){
        $this->set_auto('no');
    }
}
?>