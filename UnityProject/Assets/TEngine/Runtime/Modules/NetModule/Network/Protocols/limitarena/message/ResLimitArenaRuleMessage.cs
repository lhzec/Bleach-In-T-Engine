using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 当日可出战角色的规则id message
 */
public class ResLimitArenaRuleMessage : Message 
{
	//当日可出战角色的规则id
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//当日可出战角色的规则id
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//当日可出战角色的规则id
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 当日可出战角色的规则id
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 502105;
	}
}