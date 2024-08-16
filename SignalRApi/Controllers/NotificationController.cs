﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase 
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        public IActionResult NotificationList()
        {
            return Ok(_notificationService.TGetListAll());
        }
        [HttpGet("NotificationCountByFalse")]
        public IActionResult NotificationCountByFalse()
        {
            return Ok(_notificationService.TNotificationCountByFalse());
        }

    }
}
