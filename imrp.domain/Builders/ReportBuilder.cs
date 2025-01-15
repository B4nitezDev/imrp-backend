
using imrp.domain.Entities;

namespace imrp.domain.Builders
{
    public class ReportBuilder
    {
        private int _id;
        private string _name;
        private string _description;
        private string _path;
        private string _type;
        private string _status;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private int _userId;
        public ReportBuilder WithId(int id)
        {
            _id = id;
            return this;
        }
        public ReportBuilder WithName(string name)
        {
            _name = name;
            return this;
        }
        public ReportBuilder WithDescription(string description)
        {
            _description = description;
            return this;
        }
        public ReportBuilder WithPath(string path)
        {
            _path = path;
            return this;
        }
        public ReportBuilder WithType(string type)
        {
            _type = type;
            return this;
        }
        public ReportBuilder WithStatus(string status)
        {
            _status = status;
            return this;
        }
        public ReportBuilder WithCreatedAt(DateTime createdAt)
        {
            _createdAt = createdAt;
            return this;
        }
        public ReportBuilder WithUpdatedAt(DateTime updatedAt)
        {
            _updatedAt = updatedAt;
            return this;
        }
        public ReportBuilder WithUserId(int userId)
        {
            _userId = userId;
            return this;
        }
        public Report Build()
        {
            return new Report
            {
                Id = _id,
                Name = _name,
                Description = _description,
                Path = _path,
                Type = _type,
                Status = _status,
                CreatedAt = _createdAt,
                UpdatedAt = _updatedAt,
                UserId = _userId
            };
        }
    }
}
