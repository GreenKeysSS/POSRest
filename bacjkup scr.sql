

		SET @TS = DATE_FORMAT(NOW(),'_%Y_%m_%d_%H_%i_%s');
		 
		SET @FOLDER = 'c:/tmp/';
		SET @PREFIX = 'backup';
		SET @EXT    = '.csv';
		 
		SET @CMD = CONCAT("SELECT * FROM chamipedidosp1ben INTO OUTFILE '",@FOLDER,@PREFIX,@TS,@EXT,
						   "' FIELDS ENCLOSED BY '\' TERMINATED BY ',' ESCAPED BY '\'",
						   "  LINES TERMINATED BY '\r\n';");
		 
		PREPARE statement FROM @CMD;
		 
		EXECUTE statement;

    
   

 
