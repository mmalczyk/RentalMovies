SELECT * FROM Movies WHERE moviesid = (SELECT movieid FROM DVDs WHERE dvdid = ?)
