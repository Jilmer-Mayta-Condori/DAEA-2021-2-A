create proc BuscarCourseTitle
	@Title nvarchar(50)
as
	select * from Course where Title like '%'+@Title+'%';