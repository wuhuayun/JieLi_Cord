﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SG.ORMTool;

namespace SG.Models.Database
{


/*==========================================
 *   程序说明: tb_t_CommDataDictType的ORM模型
 *   作者姓名: C/S框架网 www.csframework.com
 *   创建日期: 2015/02/02 12:11:56
 *   最后修改: 2015/02/02 12:11:56
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   Copyright 2014-2015 东莞思谷数字技术有限公司
 *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:t_CommDataDictType,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("t_CommDataDictType", "FID", true)]
    public sealed class tb_t_CommDataDictType
    {
        public static string __TableName ="t_CommDataDictType";

        public static string __KeyName = "FID";

        [ORM_FieldAttribute(SqlDbType.Int,4,false,true,true,false,false)]
        public static string Fid = "Fid";

        [ORM_FieldAttribute(SqlDbType.VarChar, 20, false, true, false, false, false)]
        public static string FDataType = "FDataType";

        [ORM_FieldAttribute(SqlDbType.VarChar, 50, false, true, false, false, false)]
        public static string FTypeName = "FTypeName";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string FIssys = "FIssys"; 

    }
}