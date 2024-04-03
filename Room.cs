public class Room
{
    public string RoomId { get; set; }
    public string RoomName { get; set; }
    public int Capacity { get; set; }

    public Room(string roomId, string roomName, int capacity)
    {
        RoomId = roomId;
        RoomName = roomName;
        Capacity = capacity;
    }
}
