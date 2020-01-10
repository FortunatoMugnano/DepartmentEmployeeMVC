SELECT e.FirstName, e.LastName, e.Id as EmployeeId, d.DeptName, d.Id
                                        FROM Department d
                                        LEFT JOIN Employee e on d.Id = e.DepartmentId
                                        WHERE d.id = 2;