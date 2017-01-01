SELECT * FROM Customers
WHERE forename
	LIKE ? AND surname LIKE ?
	AND pesel LIKE ?
	AND phone LIKE ?
	AND address LIKE ?