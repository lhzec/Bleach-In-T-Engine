using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求进入温泉 message
 */
public class ReqEnterSpringMessage : Message 
{
	//温泉id
	int _springId;	
	//温泉类型[0:1次,1:10次]
	int _springTimeType;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//温泉id
		SerializeUtils.WriteInt(stream, _springId);
		//温泉类型[0:1次,1:10次]
		SerializeUtils.WriteInt(stream, _springTimeType);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//温泉id
		_springId = SerializeUtils.ReadInt(stream);
		//温泉类型[0:1次,1:10次]
		_springTimeType = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 温泉id
	 */
	public int SpringId
	{
		set { _springId = value; }
	    get { return _springId; }
	}
	
	/**
	 * 温泉类型[0:1次,1:10次]
	 */
	public int SpringTimeType
	{
		set { _springTimeType = value; }
	    get { return _springTimeType; }
	}
	
	
	public override int GetId() 
	{
		return 306201;
	}
}