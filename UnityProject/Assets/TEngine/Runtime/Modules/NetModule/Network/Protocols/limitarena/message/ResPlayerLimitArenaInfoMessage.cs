using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家无间之战数据信息 message
 */
public class ResPlayerLimitArenaInfoMessage : Message 
{
	//玩家竞技场信息
	LimitArenaInfo _limitArenaInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家竞技场信息
		SerializeUtils.WriteBean(stream, _limitArenaInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家竞技场信息
		_limitArenaInfo = SerializeUtils.ReadBean<LimitArenaInfo>(stream);
	}
	
	/**
	 * 玩家竞技场信息
	 */
	public LimitArenaInfo LimitArenaInfo
	{
		set { _limitArenaInfo = value; }
	    get { return _limitArenaInfo; }
	}
	
	
	public override int GetId() 
	{
		return 502103;
	}
}