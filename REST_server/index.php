<?php
include("connection.php");

$db = new dbObj();
$connection = $db->getConnection();
$request_method = $_SERVER["REQUEST_METHOD"];
$authkey = "totallysecureauthkey";


switch($request_method){
    case 'GET': //Select
        if(!empty($_GET["id"])){
            $id = intval($_GET["id"]);
            get_videogame_by_id($id);
        }else
            get_all_videogames();
    break;

    case 'POST': //Insert
        insert_videogame();
    break;

    case 'PUT': //Update
        update_videogame();
    break;

    case 'DELETE': //Delete
        $id = intval($_GET["id"]);
        delete_videogame($id);
    break;

    default:
     header("HTTP/1.0 405 Method Not Allowed");
    break;
}

function get_all_videogames(){
    global $connection;
    $query = "SELECT * FROM videogames";
    $response = array();
    $result = mysqli_query($connection, $query);
    while($row=mysqli_fetch_array($result)) 
        $response[] = $row;

    header('Content-Type: application/json');
    echo json_encode($response);
}

function get_videogame_by_id($id=0){
    global $connection;
    $query = "SELECT * FROM videogames";
    if($id != 0) $query.= " WHERE id =".$id." LIMIT 1"; //
    $response = array();
    $result = mysqli_query($connection, $query);
    while($row=mysqli_fetch_array($result)) 
        $response[] = $row;

    header('Content-Type: application/json');
    echo json_encode($response);
}

function insert_videogame(){
    global $connection;
    global $authkey;

    $data = json_decode(file_get_contents('php://input'),true);
    $reqauthkey = $data["authkey"];

    if ($reqauthkey == $authkey) {
        $title = $data["title"];
        $publisher = $data["publisher"];
        $price = $data["price"];

        $query = "INSERT INTO videogames SET title =' ". $title." ', publisher =' ".$publisher." ',price=' ".$price." ' ";

        if(mysqli_query($connection, $query)){
            $response = array(
                'status' => 1,
                'status_message' => 'Videogame inserted successfully'
            );
        }else{
            $response = array(
                'status' => 0,
                'status_message' => 'Videogame insertion failed'
            );
        }

        header('Content-Type: application/json');
    } else {
        $response = array(
            'status' => 0,
            'status_message' => 'Videogame insertion unauthorized'
        );
        header("HTTP/1.0 401 Unauthorized");
    }
    echo json_encode($response);
}

function update_videogame(){
    global $connection;
    global $authkey;

    $data = json_decode(file_get_contents('php://input'),true);
    $reqauthkey = $data["authkey"];

    if ($reqauthkey == $authkey) {
        $id = $data["id"];
        $newtitle = $data["title"];
        $newpublisher = $data["publisher"];
        $newprice = $data["price"];

        $query = "UPDATE videogames SET title =' ". $newtitle." ', publisher =' ".$newpublisher." ',price=' ".$newprice." ' WHERE id =".$id." LIMIT 1";

        if (mysqli_query($connection, $query)){
            $response = array(
                'status' => 1,
                'status_message' => 'Videogame updated successfully',
            );
        }else{
            $response = array(
                'status' => 0,
                'status_message' => 'Videogame update failed',
            );
        }

        header('Content-Type: application/json');
    } else {
        $response = array(
            'status' => 0,
            'status_message' => 'Videogame update unauthorized'
        );
        header("HTTP/1.0 401 Unauthorized");
    }
    echo json_encode($response);
}

function delete_videogame($id){
    global $connection;
    global $authkey;

    $data = json_decode(file_get_contents('php://input'),true);
    $reqauthkey = $data["authkey"];

    if ($reqauthkey == $authkey) {
        $query= "DELETE FROM videogames WHERE videogames.id = ".$id;

        if(mysqli_query($connection, $query)){
            $response = array(
                'status' => 1,
                'status_message' => 'Videogame deleted successfully'
            );
        }else{
            $response = array(
                'status' => 0,
                'status_message' => 'Videogame deletion failed'
            );
        }

        header('Content-Type: application/json');
    } else {
        $response = array(
            'status' => 0,
            'status_message' => 'Videogame deletion unauthorized'
        );
        header("HTTP/1.0 401 Unauthorized");
    }
    echo json_encode($response);
}