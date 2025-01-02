﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain;
using SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.DTO;
using SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.DTO.Add;
using SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.DTO.Get;
using SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Repositories;

namespace SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportRepository reportRepository;
        private readonly IMapper mapper;

        public ReportController(IReportRepository reportRepository,IMapper mapper)
        {
            this.reportRepository = reportRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("Post1Year")]
        public async Task<IActionResult> GetPostIn1YearAgo()
        {
            //Get Data from Database - Domain models
            var postDomain = await reportRepository.getPostIn1YearAgo();

            //Convert Domain to Dto
            return Ok(mapper.Map<List<HomePostDto>>(postDomain));
        }
        [HttpGet]
        [Route("Post30Days")]
        public async Task<IActionResult> getPostsIn30DaysAgo()
        {
            //Get Data from Database - Domain models
            var postDomain = await reportRepository.getPostsIn30DaysAgo();

            //Convert Domain to Dto
            return Ok(mapper.Map<List<HomePostDto>>(postDomain));
        }

        [HttpGet]
        [Route("PostToday")]
        public async Task<IActionResult> getPostsInToday()
        {
            //Get Data from Database - Domain models
            var postDomain = await reportRepository.getPostsInToday();

            //Convert Domain to Dto
            return Ok(mapper.Map<List<HomePostDto>>(postDomain));
        }
        [HttpGet]
        [Route("User1Year")]
        public async Task<IActionResult> getUsersIn1YearAgo()
        {
            //Get Data from Database - Domain models
            var postDomain = await reportRepository.getUsersIn1YearAgo();

            //Convert Domain to Dto
            return Ok(mapper.Map<List<UserDto>>(postDomain));
        }

        [HttpGet]
        [Route("User30Days")]
        public async Task<IActionResult> getUsersIn30DaysAgo()
        {
            //Get Data from Database - Domain models
            var postDomain = await reportRepository.getUsersIn30DaysAgo();

            //Convert Domain to Dto
            return Ok(mapper.Map<List<UserDto>>(postDomain));
        }
        [HttpGet]
        [Route("UserToday")]
        public async Task<IActionResult> getUsersInToday()
        {
            //Get Data from Database - Domain models
            var postDomain = await reportRepository.getUsersInToday();

            //Convert Domain to Dto
            return Ok(mapper.Map<List<UserDto>>(postDomain));
        }

        [HttpGet]
        [Route("Answer1Year")]
        public async Task<IActionResult> getAnswersIn1YearAgo()
        {
            //Get Data from Database - Domain models
            var postDomain = await reportRepository.getAnswersIn1YearAgo();

            //Convert Domain to Dto
            return Ok(mapper.Map<List<AnswerDto>>(postDomain));
        }
        [HttpGet]
        [Route("Answer30Days")]
        public async Task<IActionResult> getAnswersIn30DaysAgo()
        {
            //Get Data from Database - Domain models
            var postDomain = await reportRepository.getAnswersIn30DaysAgo();

            //Convert Domain to Dto
            return Ok(mapper.Map<List<AnswerDto>>(postDomain));
        }

        [HttpGet]
        [Route("AnswerToday")]
        public async Task<IActionResult> getAnwsersInToday()
        {
            //Get Data from Database - Domain models
            var postDomain = await reportRepository.getAnwsersInToday();

            //Convert Domain to Dto
            return Ok(mapper.Map<List<AnswerDto>>(postDomain));
        }

        [HttpPost]
        [Route("reportViolation")]
        public async Task<IActionResult> createReport(AddReport addReport)
        {       
            var reportDomain = mapper.Map<Report>(addReport);
            if (await reportRepository.createReport(reportDomain))
            {
                return Ok(new { message = "Báo cáo bài viết thành công " });
            }
            return BadRequest("Báo cáo thất bại");
        }

        [HttpGet]
        [Route("getReportsOfPost")]
        public async Task<IActionResult> getReportsFromPost(Guid postId)
        {
            var reportsDomain = await reportRepository.getReportsFromPost(postId);

            if(reportsDomain.Count>0)
            {
                return Ok(mapper.Map<List<ReportDto>>(reportsDomain));
            }
            return NotFound("Không có báo cáo vi phạm nào");
        }

        [HttpGet]
        [Route("getAllReportsPost1Year_unfinish")]
        public async Task<IActionResult> getAllReportsIn1YearAgo_unfinish()
        {
            //Get Data from Database - Domain models
            var posts = await reportRepository.getAllReportsInAYear_unfinish();
            if(posts.Any())
            //Convert Domain to Dto
            return Ok(posts);
            return NotFound("Không có dữ liệu");
        }
        [HttpGet]
        [Route("getAllReportsPost30Days_unfinish")]
        public async Task<IActionResult> getReportsIn30DaysAgo_unfinish()
        {
            //Get Data from Database - Domain models
            var posts = await reportRepository.getAllReportsIn30Days_unfinish();
            if(posts.Any())
            //Convert Domain to Dto
            return Ok(posts);
            return NotFound("Không có dữ liệu");
        }

        [HttpGet]
        [Route("getAllReportsInADayBefore_unfinish")]
        public async Task<IActionResult> getReportsInADayAgo_unfinish()
        {
            //Get Data from Database - Domain models
            var posts = await reportRepository.getAllReportsInADayBefore_unfinish();
            if (posts.Any())
                //Convert Domain to Dto
                return Ok(posts);
            return NotFound("Không có dữ liệu");
        }
        //
        [HttpGet]
        [Route("getAllReportsPost1Year_finished")]
        public async Task<IActionResult> getAllReportsIn1YearAgo_finished()
        {
            //Get Data from Database - Domain models
            var posts = await reportRepository.getAllReportsInAYear_finished();
            if (posts.Any())
                //Convert Domain to Dto
                return Ok(posts);
            return NotFound("Không có dữ liệu");
        }
        [HttpGet]
        [Route("getAllReportsPost30Days_finished")]
        public async Task<IActionResult> getReportsIn30DaysAgo_finished()
        {
            //Get Data from Database - Domain models
            var posts = await reportRepository.getAllReportsIn30Days_finished();
            if (posts.Any())
                //Convert Domain to Dto
                return Ok(posts);
            return NotFound("Không có dữ liệu");
        }

        [HttpGet]
        [Route("getAllReportsInADayBefore_finished")]
        public async Task<IActionResult> getReportsInADayAgo_finished()
        {
            //Get Data from Database - Domain models
            var posts = await reportRepository.getAllReportsInADayBefore_finished();
            if (posts.Any())
                //Convert Domain to Dto
                return Ok(posts);
            return NotFound("Không có dữ liệu");
        }
    }
}
