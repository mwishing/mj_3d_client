﻿using UnityEngine;
using System.Collections;

public class Account {

	private static Account instance_;
    public string http_url = "http://222.73.139.48:4001/login?";
    public string account_ = "11";
    public string password_ = "22";
    public string nickname_ = "";
    public int roomcard_ = 0;

    private Account()
    {

    }

    public static Account GetInstance()
    {
        instance_  = instance_ ?? new Account();
        return instance_;
    }
}
