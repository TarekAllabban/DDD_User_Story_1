using Microsoft.AspNetCore.Mvc;

namespace DDD_User_Story_1._3Infrastructure
{
    [Route("api/room")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        //private readonly RoomService _roomService;

        //public RoomController(RoomService roomService)
        //{
        //    _roomService = roomService;
        //}

    //    [HttpGet(Name = "GetHello")]
    //    public IActionResult<Infrastructure.Dto.RoomDto> Get()
    //    {
    //        var inputValue = new Room();
    //        inputValue = _roomService.GetRoomById(1);

    //        var retValue = new Infrastructure.Dto.RoomDto();
    //        retValue.number = "1";
    //        retValue.name = "Zimmer 1";
    //        return retValue;
    //    }
    //}
    
    //[HttpPut("api/room/{roomId}/person")]
    //public async Task<Room> putPersontoRoom(PersonDto person)
    //{
        
    //    // Todo: PersonDto zu Domain-Person mappen       
    //    // Todo: Service aufrufen und hinzufügen
    }
    
}
