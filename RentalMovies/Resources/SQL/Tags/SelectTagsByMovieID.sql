SELECT * from Tags
WHERE tagId IN
(
	SELECT tagId
	FROM MoviesTags
	WHERE movieId = ?)
AND category = ?