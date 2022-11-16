using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using SER.Domain.Interfaces;
using SER.Domain.Models;
using SER.Infrastructure.Data;
using SER.Infrastructure.ViewModel.DuAn;
using SER.Infrastructure.ViewModel.Resquest;
using System.Net;

namespace SER.Infrastructure.Repositories
{
    public class DuAnRepository:Repository<Duan>, IDuAnRepository
    {
        private readonly IMapper _mapper;
        private readonly VI_GPMBContext _context;
        public DuAnRepository(VI_GPMBContext context, IMapper mapper):base(context)
        {
            _mapper = mapper;
            _context = context;
        }
        public IQueryable<DuAnReponse> GetAlls()
        {
            var duan = _context.Duans.Select(da => _mapper.Map<DuAnReponse>(da));
            //await duan.ToListAsync();
            //orderby da.Id descending
            //select(duans).ToList();
            //from das in da.DefaultIfEmpty()
            //.Take(5).Skip(4)
            /*var listDuAn = await duan.Skip((parameter.PageIndex - 1) * parameter.PageSize)
                                     .Take(parameter.PageSize)
                                     .ToListAsync();*/

            //await AddNameDM(listDuAn);
            return duan;
        }
        public async Task AddDM( List<DuAnReponse>? listDuAn = null, DuAnReponse? duAn = null)
        {
            
            if(listDuAn is not null)
            {
                //var chuSoHuu =_context.Chusohuus.GroupBy(c => c.DuAnId);
                var quyTrinh = await _context.Dmquytrinhs.Select(q=> new {Id = q.Id, Name = q.TenQuyTrinh}).ToListAsync();
                var tinhTrang = await _context.Dmtinhtrangduans.Select(q=> new {Id = q.Id, Name = q.TenTinhTrang}).ToListAsync();
                foreach(var duan in listDuAn)
                {
                    duan.SLAnhHuong = await _context.Chusohuus.Where(c=>c.DuAnId == duan.Id).CountAsync();
                    duan.SLDakiemDuyet = await _context.Chusohuus.Where(c => c.TinhTrangHienTaiId >0).CountAsync();
                    duan.SLDaPheDuyet = await _context.Chusohuus.Where(c => c.TinhTrangHienTaiId >1 ).CountAsync();

                    duan.TenQuyTrinh = quyTrinh.Find(m => m.Id == duan.QuyTrinhId.Value).Name;
                    duan.TinhTrangHienTai = tinhTrang.Find(m => m.Id == duan.QuyTrinhId.Value).Name;
                }
            }
            else
            {
                duAn.SLAnhHuong = await _context.Chusohuus.Where(c => c.DuAnId == duAn.Id).CountAsync();
                duAn.SLDakiemDuyet = await _context.Chusohuus.Where(c => c.TinhTrangHienTaiId > 0).CountAsync();
                duAn.SLDaPheDuyet = await _context.Chusohuus.Where(c => c.TinhTrangHienTaiId > 1).CountAsync();
                duAn.TenQuyTrinh = await _context.Dmquytrinhs.Where(d => d.Id == duAn.QuyTrinhId).Select(d => d.TenQuyTrinh).FirstOrDefaultAsync();
                duAn.TinhTrangHienTai = await _context.Dmtinhtrangduans.Where(d => d.Id == duAn.QuyTrinhId).Select(d => d.TenTinhTrang).FirstOrDefaultAsync();
            }
        }
    }
}
