using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 特殊商店购买 message
 */
public class ResBuySpecialShopItemMessage : Message 
{
	//结果[0:成功,1:商店已经关闭,2:功能未开放,3:魂玉不足]
	int _result;	
	//序号
	int _index;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//结果[0:成功,1:商店已经关闭,2:功能未开放,3:魂玉不足]
		SerializeUtils.WriteInt(stream, _result);
		//序号
		SerializeUtils.WriteInt(stream, _index);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//结果[0:成功,1:商店已经关闭,2:功能未开放,3:魂玉不足]
		_result = SerializeUtils.ReadInt(stream);
		//序号
		_index = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 结果[0:成功,1:商店已经关闭,2:功能未开放,3:魂玉不足]
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 序号
	 */
	public int Index
	{
		set { _index = value; }
	    get { return _index; }
	}
	
	
	public override int GetId() 
	{
		return 225102;
	}
}