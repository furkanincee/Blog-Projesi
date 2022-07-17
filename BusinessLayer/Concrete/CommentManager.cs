using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal cd;
        public void AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAllCommentss()
        {
            throw new NotImplementedException();
        }
    }
}
