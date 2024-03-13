﻿using Flunt.Notifications;

namespace IWantApp.Domain;

public abstract class Entity : Notifiable<Notification>
{
    public Entity()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string CreateBy { get; set; }
    public DateTime CreateOn { get; set; }
    public string EditBy { get; set; }
    public DateTime EditOn { get; set; }
}
