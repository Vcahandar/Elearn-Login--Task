﻿namespace ElearnBackEnd.Model
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool SoftDelete { get; set; } = false;
        public DateTime CreateTime { get; set; }

    }
}
