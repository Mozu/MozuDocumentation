Ext.widget({
   xtype:'mz-form-entity' ,
   layout:{
       type:'vbox',
       align:'stretch'
   },
   items:[
       {
           name:'title',
           xtype:'mz-input-text',
             fieldLabel: 'title'
       },
        {
           name:'body',
           xtype:'mz-input-richtext',
           fieldLabel: 'body',
         
           height:500
       }
       ]
   
});
