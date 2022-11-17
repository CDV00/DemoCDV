using AutoMapper;
using SER.Domain.Interfaces;
using SER.Domain.Models;
using SER.Infrastructure.Data;
using SER.Infrastructure.ViewModel.KhoKhan;
using System.Linq.Expressions;

namespace SER.Infrastructure.Repositories
{
    public class KhoKhanRepository : Repository<Khokhan>, IKhoKhanRepository
    {
        private readonly IMapper _mapper;
        private readonly VI_GPMBContext _context;
        public KhoKhanRepository(VI_GPMBContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
            _context = context;
        }
        public IQueryable<Khokhan> GetAlls(Expression<Func<Khokhan, bool>> filter = null, Func<IQueryable<Khokhan>, IOrderedQueryable<Khokhan>> orderBy = null)
        {
            IQueryable<Khokhan> khokhans = _context.Khokhans.AsQueryable();
            IQueryable<Dmtinhtrangkhokhan> dmtinhtrangkhokhans = _context.Dmtinhtrangkhokhans.AsQueryable();
            IQueryable<Duan> duan = _context.Duans.AsQueryable();
            if (filter != null)
            {
                khokhans.Where(filter);
            }
            if (orderBy != null)
            {
                khokhans = orderBy(khokhans).AsQueryable();
            }
            khokhans = from kk in khokhans
                       join tt in dmtinhtrangkhokhans on kk.TinhTrangId equals tt.Id into f
                       from tt in f.DefaultIfEmpty()
                       join da in duan on kk.DuAnId equals da.Id
                       select new Khokhan(kk) { TenTinhTrang = tt.TenTinhTrang, TenDuAn = da.TenDuAn};

            return khokhans;
        }
        public IQueryable<Khokhan> KhoKhanById(int id)
        {

            var khoKhans = from kk in _context.Khokhans.Where(kk => kk.Id == id).AsQueryable()
                           join dmTT in _context.Dmtinhtrangkhokhans on kk.TinhTrangId equals dmTT.Id
                           join da in _context.Duans on kk.DuAnId equals da.Id
                           select new Khokhan(kk) { TenTinhTrang = dmTT.TenTinhTrang, TenDuAn = da.TenDuAn };
            /*var khoKhan = _context.Khokhans.Select(da => new KhoKhanReponse()
            {
                TenTinhTrang = ttKK.FirstOrDefault(tt => tt.Id == da.TinhTrangId).Name,
            });*/
            //await duan.ToListAsync();
            //orderby da.Id descending
            //select(duans).ToList();
            //from das in da.DefaultIfEmpty()
            //.Take(5).Skip(4)
            /*var listDuAn = await duan.Skip((parameter.PageIndex - 1) * parameter.PageSize)
                                     .Take(parameter.PageSize)
                                     .ToListAsync();*/

            //await AddNameDM(listDuAn);
            return khoKhans;
        }
    }



}
