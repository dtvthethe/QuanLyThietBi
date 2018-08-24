using System;

namespace QuanLyThietBi.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        QuanLyThietBiDbContext Init();
    }
}