﻿/*
* Copyright (c) 2014 Universal Technical Resource Services, Inc.
*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v. 2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at http://mozilla.org/MPL/2.0/.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATMLCommonLibrary.forms;
using ATMLModelLibrary.model.equipment;

namespace ATMLCommonLibrary.controls.network
{
    public partial class NetworkNodeForm : ATMLForm
    {
        public NetworkNode NetworkNode  
        {
            get { return networkNodeControl.NetworkNode; }
            set { networkNodeControl.NetworkNode = value; }
        }

        public HardwareItemDescription HardwareItemDescription
        {
            get { return networkNodeControl.HardwareItemDescription; }
            set { networkNodeControl.HardwareItemDescription = value;
            }
        }

        public NetworkNodeForm()
        {
            InitializeComponent();
        }
    }
}
