using API.Contracts;
using API.Data;
using API.Models;
using System;

namespace API.Repositories;

public class GeneralRepository<TEntity> : IGeneralRepository<TEntity>
    where TEntity : class
{
    protected readonly BookingDbContext _context;

    public GeneralRepository(BookingDbContext context)
    {
        _context = context;
    }

    public ICollection<TEntity> GetAll()
    {
        return _context.Set<TEntity>().ToList();
    }

    public TEntity? GetByGuid(Guid guid)
    {
        return _context.Set<TEntity>().Find(guid);
    }


    
    public TEntity? Create(TEntity TEntity)
    {
        try
        {
            _context.Set<TEntity>().Add(TEntity);
            _context.SaveChanges();
            return TEntity;
        }
        catch
        {
            return null;
        }
    }

    public bool Update(TEntity TEntity)
    {
        try
        {
            _context.Set<TEntity>().Update(TEntity);
            _context.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool Delete(Guid guid)
    {
        try
        {
            var TEntity = GetByGuid(guid);
            if (TEntity is null)
            {
                return false;
            }

            _context.Set<TEntity>().Remove(TEntity);
            _context.SaveChanges();
            return true;
        }
        catch 
        {
            return false;
        }
    }
}