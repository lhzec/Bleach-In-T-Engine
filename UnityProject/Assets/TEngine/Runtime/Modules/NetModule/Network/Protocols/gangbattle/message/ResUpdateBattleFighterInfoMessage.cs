using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 更新出战角色及魂共鸣技能 message
 */
public class ResUpdateBattleFighterInfoMessage : Message 
{
	//0：更新成功，1：更新失败
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：更新成功，1：更新失败
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：更新成功，1：更新失败
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：更新成功，1：更新失败
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 112103;
	}
}