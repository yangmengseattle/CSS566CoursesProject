﻿using Backend_Api.Repo_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Api.Repository {
    /**
     * Provides CRUD operations for the Course model.
     **/
    public interface ICourseRepository {
        void CreateCourse(Course course);
        void UpdateCourse(Course course);
        void GetCourse(string id);
        void DeleteCourse(string id);
    }
}